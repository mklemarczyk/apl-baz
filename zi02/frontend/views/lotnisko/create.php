<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Lotnisko */

$this->title = 'Stwórz lotnisko';
$this->params['breadcrumbs'][] = ['label' => 'Lotniska', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="lotnisko-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
