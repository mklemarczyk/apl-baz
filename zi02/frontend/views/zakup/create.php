<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Zakup */

$this->title = 'Stwórz zakup';
$this->params['breadcrumbs'][] = ['label' => 'Zakupy', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="zakup-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'klienci' => $klienci,
    ]) ?>

</div>
